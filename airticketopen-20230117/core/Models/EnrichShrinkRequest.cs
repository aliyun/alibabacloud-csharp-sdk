// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class EnrichShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Number of adult passengers (1-9)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("adults")]
        [Validation(Required=false)]
        public int? Adults { get; set; }

        /// <summary>
        /// <para>Cabin class: ALL_CABIN: All cabin classes; Y: Economy; FC: First Class and Business Class; S: Premium Economy; YS: Economy and Premium Economy; YSC: Economy, Premium Economy, and Business Class;</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_CABIN</para>
        /// </summary>
        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClass { get; set; }

        /// <summary>
        /// <para>Number of child passengers (0-9)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("children")]
        [Validation(Required=false)]
        public int? Children { get; set; }

        /// <summary>
        /// <para>Number of infant passengers (0-9)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("infants")]
        [Validation(Required=false)]
        public int? Infants { get; set; }

        /// <summary>
        /// <para>Trip information</para>
        /// </summary>
        [NameInMap("journey_param_list")]
        [Validation(Required=false)]
        public string JourneyParamListShrink { get; set; }

        /// <summary>
        /// <para>The <c>solution_id</c> returned by the Search interface</para>
        /// 
        /// <b>Example:</b>
        /// <para>eJwz8DeySEo0NjQ01TU3TU7TNTFINNO1SE5O0jVKM0hKNjEwTElLNYwz0A32cNT1dfPVNTIwMjYwNjRQ8/A3NLI01Q0Ic0cRBwBVFxJJ</para>
        /// </summary>
        [NameInMap("solution_id")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

    }

}
