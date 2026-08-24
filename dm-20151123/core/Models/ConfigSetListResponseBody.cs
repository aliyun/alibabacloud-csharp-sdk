// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ConfigSetListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of configuration sets.</para>
        /// </summary>
        [NameInMap("ConfigSets")]
        [Validation(Required=false)]
        public List<ConfigSetListResponseBodyConfigSets> ConfigSets { get; set; }
        public class ConfigSetListResponseBodyConfigSets : TeaModel {
            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of associated sender addresses.</para>
            /// </summary>
            [NameInMap("FromAddresses")]
            [Validation(Required=false)]
            public List<string> FromAddresses { get; set; }

            /// <summary>
            /// <para>The configuration set ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The IP pool.</para>
            /// </summary>
            [NameInMap("IpPool")]
            [Validation(Required=false)]
            public ConfigSetListResponseBodyConfigSetsIpPool IpPool { get; set; }
            public class ConfigSetListResponseBodyConfigSetsIpPool : TeaModel {
                /// <summary>
                /// <para>The associated IP pool ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("IpPoolId")]
                [Validation(Required=false)]
                public string IpPoolId { get; set; }

                /// <summary>
                /// <para>The associated IP pool name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("IpPoolName")]
                [Validation(Required=false)]
                public string IpPoolName { get; set; }

            }

            [NameInMap("IsPublicChannelBackoff")]
            [Validation(Required=false)]
            public bool? IsPublicChannelBackoff { get; set; }

            /// <summary>
            /// <para>The configuration set name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ValidationOption")]
            [Validation(Required=false)]
            public ConfigSetListResponseBodyConfigSetsValidationOption ValidationOption { get; set; }
            public class ConfigSetListResponseBodyConfigSetsValidationOption : TeaModel {
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("ForbiddenStatusList")]
                [Validation(Required=false)]
                public List<string> ForbiddenStatusList { get; set; }

                [NameInMap("ForbiddenSubStatusList")]
                [Validation(Required=false)]
                public List<string> ForbiddenSubStatusList { get; set; }

            }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Indicates whether there is a next page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that match the request conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
