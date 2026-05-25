// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emas_appmonitor20190611.Models
{
    public class EventFilter : TeaModel {
        /// <summary>
        /// <para>key</para>
        /// 
        /// <b>Example:</b>
        /// <para>startTime</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>op</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <remarks>
        /// </remarks>
        /// </summary>
        [NameInMap("Op")]
        [Validation(Required=false)]
        public string Op { get; set; }

        /// <summary>
        /// <para>filters</para>
        /// </summary>
        [NameInMap("SubFilters")]
        [Validation(Required=false)]
        public List<EventFilter> SubFilters { get; set; }

        /// <summary>
        /// <para>values</para>
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<string> Values { get; set; }

    }

}
