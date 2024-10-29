// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class SearchShrinkRequest : TeaModel {
        /// <summary>
        /// <para>adult passenger amount 1-9</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("adults")]
        [Validation(Required=false)]
        public int? Adults { get; set; }

        /// <summary>
        /// <para>itinerary list</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("air_legs")]
        [Validation(Required=false)]
        public string AirLegsShrink { get; set; }

        /// <summary>
        /// <para>cabin class</para>
        /// <ol>
        /// <item><description><b>ALL_CABIN</b> : all cabin class</description></item>
        /// <item><description><b>Y</b> : economy class</description></item>
        /// <item><description><b>FC</b> : first class and business class</description></item>
        /// <item><description><b>S</b> : premium economy class</description></item>
        /// <item><description><b>YS</b> : economy class and premium economy class</description></item>
        /// <item><description><b>YSC</b> : economy class, premium economy class and business class</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_CABIN</para>
        /// </summary>
        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClass { get; set; }

        /// <summary>
        /// <para>child passenger amount 0-9</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("children")]
        [Validation(Required=false)]
        public int? Children { get; set; }

        /// <summary>
        /// <para>infant passenger amount 0-9</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("infants")]
        [Validation(Required=false)]
        public int? Infants { get; set; }

        /// <summary>
        /// <para>search controls</para>
        /// </summary>
        [NameInMap("search_control_options")]
        [Validation(Required=false)]
        public string SearchControlOptionsShrink { get; set; }

    }

}
