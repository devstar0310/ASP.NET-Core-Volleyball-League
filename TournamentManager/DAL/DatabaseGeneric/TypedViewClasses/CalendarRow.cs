﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.7.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;

namespace TournamentManager.DAL.TypedViewClasses
{
	/// <summary>Class which represents a row in the typed view 'Calendar'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the property <see cref="TournamentManager.DAL.FactoryClasses.QueryFactory.Calendar"/>. </remarks>
	[Serializable]
	public partial class CalendarRow 
	{
		partial void OnCreated();
		
		/// <summary>Initializes a new instance of the <see cref="CalendarRow"/> class.</summary>
		public CalendarRow()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the ChangeSerial field.</summary>
		public System.Int64 ChangeSerial { get; set; }
		/// <summary>Gets or sets the GuestTeamId field.</summary>
		public System.Int64 GuestTeamId { get; set; }
		/// <summary>Gets or sets the GuestTeamNameForRound field.</summary>
		public System.String GuestTeamNameForRound { get; set; }
		/// <summary>Gets or sets the HomeTeamId field.</summary>
		public System.Int64 HomeTeamId { get; set; }
		/// <summary>Gets or sets the HomeTeamNameForRound field.</summary>
		public System.String HomeTeamNameForRound { get; set; }
		/// <summary>Gets or sets the Id field.</summary>
		public System.Int64 Id { get; set; }
		/// <summary>Gets or sets the ModifiedOn field.</summary>
		public System.DateTime ModifiedOn { get; set; }
		/// <summary>Gets or sets the PlannedEnd field.</summary>
		public Nullable<System.DateTime> PlannedEnd { get; set; }
		/// <summary>Gets or sets the PlannedStart field.</summary>
		public Nullable<System.DateTime> PlannedStart { get; set; }
		/// <summary>Gets or sets the RoundDescription field.</summary>
		public System.String RoundDescription { get; set; }
		/// <summary>Gets or sets the RoundId field.</summary>
		public System.Int64 RoundId { get; set; }
		/// <summary>Gets or sets the RoundName field.</summary>
		public System.String RoundName { get; set; }
		/// <summary>Gets or sets the RoundTypeDescription field.</summary>
		public System.String RoundTypeDescription { get; set; }
		/// <summary>Gets or sets the RoundTypeName field.</summary>
		public System.String RoundTypeName { get; set; }
		/// <summary>Gets or sets the TournamentId field.</summary>
		public Nullable<System.Int64> TournamentId { get; set; }
		/// <summary>Gets or sets the TournamentName field.</summary>
		public System.String TournamentName { get; set; }
		/// <summary>Gets or sets the VenueCity field.</summary>
		public System.String VenueCity { get; set; }
		/// <summary>Gets or sets the VenueDirection field.</summary>
		public System.String VenueDirection { get; set; }
		/// <summary>Gets or sets the VenueExtension field.</summary>
		public System.String VenueExtension { get; set; }
		/// <summary>Gets or sets the VenueId field.</summary>
		public Nullable<System.Int64> VenueId { get; set; }
		/// <summary>Gets or sets the VenueLatitude field.</summary>
		public Nullable<System.Double> VenueLatitude { get; set; }
		/// <summary>Gets or sets the VenueLongitude field.</summary>
		public Nullable<System.Double> VenueLongitude { get; set; }
		/// <summary>Gets or sets the VenueName field.</summary>
		public System.String VenueName { get; set; }
		/// <summary>Gets or sets the VenuePostalCode field.</summary>
		public System.String VenuePostalCode { get; set; }
		/// <summary>Gets or sets the VenueStreet field.</summary>
		public System.String VenueStreet { get; set; }
	}
}

