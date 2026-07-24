// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class SearchShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The number of adult passengers. Valid values: 1 to 9.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("adults")]
        [Validation(Required=false)]
        public int? Adults { get; set; }

        /// <summary>
        /// <para>The journey array.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("air_legs")]
        [Validation(Required=false)]
        public string AirLegsShrink { get; set; }

        /// <summary>
        /// <para>The cabin class. Valid values: ALL_CABIN: all cabin classes. Y: economy class. FC: first class and business class. S: premium economy class. YS: economy class and premium economy class. YSC: economy class, premium economy class, and business class.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_CABIN</para>
        /// </summary>
        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClass { get; set; }

        /// <summary>
        /// <para>The number of child passengers. Valid values: 0 to 9.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("children")]
        [Validation(Required=false)]
        public int? Children { get; set; }

        /// <summary>
        /// <para>The number of infant passengers. Valid values: 0 to 9.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("infants")]
        [Validation(Required=false)]
        public int? Infants { get; set; }

        /// <summary>
        /// <para>The search control options. This parameter is optional.</para>
        /// </summary>
        [NameInMap("search_control_options")]
        [Validation(Required=false)]
        public string SearchControlOptionsShrink { get; set; }

    }

}
