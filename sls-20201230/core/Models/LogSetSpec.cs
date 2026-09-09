// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class LogSetSpec : TeaModel {
        /// <summary>
        /// <para>The default sort direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc: ascending order.</description></item>
        /// <item><description>desc: descending order.</description></item>
        /// </list>
        /// <para>Default value: asc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("default_order")]
        [Validation(Required=false)]
        public string DefaultOrder { get; set; }

        /// <summary>
        /// <para>The list of fields.</para>
        /// </summary>
        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<FieldSpec> Fields { get; set; }

        /// <summary>
        /// <para>The list of hidden fields. These fields are not displayed in the interface by default.</para>
        /// </summary>
        [NameInMap("hidden_fields")]
        [Validation(Required=false)]
        public List<string> HiddenFields { get; set; }

        /// <summary>
        /// <para>The list of Displayed Fields, in sorting order by display priority.</para>
        /// </summary>
        [NameInMap("name_fields")]
        [Validation(Required=false)]
        public List<string> NameFields { get; set; }

        /// <summary>
        /// <para>The list of sort fields, used for default sorting.</para>
        /// </summary>
        [NameInMap("ordered_fields")]
        [Validation(Required=false)]
        public List<string> OrderedFields { get; set; }

        /// <summary>
        /// <para>The list of tag fields. Tag fields are aggregated together for display and analysis by default.</para>
        /// </summary>
        [NameInMap("tag_fields")]
        [Validation(Required=false)]
        public List<string> TagFields { get; set; }

        /// <summary>
        /// <para>The name of the time field. The field must be of the timestamp type and supports seconds, milliseconds, microseconds, and nanoseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>time</para>
        /// </summary>
        [NameInMap("time_field")]
        [Validation(Required=false)]
        public string TimeField { get; set; }

    }

}
