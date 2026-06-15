// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ConfigSetListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of ConfigSets.</para>
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
            /// <para>The list of from addresses associated with the ConfigSet.</para>
            /// </summary>
            [NameInMap("FromAddresses")]
            [Validation(Required=false)]
            public List<string> FromAddresses { get; set; }

            /// <summary>
            /// <para>The ConfigSet ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The IP pool associated with the ConfigSet.</para>
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
            /// <para>The ConfigSet name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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
        /// <para>Indicates whether more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The page size.</para>
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
        /// <para>The total number of matching entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
