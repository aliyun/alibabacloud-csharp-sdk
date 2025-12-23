// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class UpdateFunctionInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The parameters that are used to create the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{             &quot;name&quot;: &quot;title_field&quot;,             &quot;value&quot;: &quot;title&quot;         }</para>
        /// </summary>
        [NameInMap("createParameters")]
        [Validation(Required=false)]
        public List<UpdateFunctionInstanceRequestCreateParameters> CreateParameters { get; set; }
        public class UpdateFunctionInstanceRequestCreateParameters : TeaModel {
            /// <summary>
            /// <para>The name of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>title_field</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The value of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>title</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The cron expression used to schedule periodic training, in the format of (Minutes Hours DayofMonth Month DayofWeek). The default value is empty, which indicates that no periodic training is performed. DayofWeek 0 indicates Sunday.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;0 3 ? * 0,1,3,5&quot;</para>
        /// </summary>
        [NameInMap("cron")]
        [Validation(Required=false)]
        public string Cron { get; set; }

        /// <summary>
        /// <para>The description of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test instance</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The parameters that are used.</para>
        /// </summary>
        [NameInMap("usageParameters")]
        [Validation(Required=false)]
        public List<UpdateFunctionInstanceRequestUsageParameters> UsageParameters { get; set; }
        public class UpdateFunctionInstanceRequestUsageParameters : TeaModel {
            /// <summary>
            /// <para>The name of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>allow_dict_id</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The value of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
