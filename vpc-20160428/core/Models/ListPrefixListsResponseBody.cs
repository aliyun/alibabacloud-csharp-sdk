// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListPrefixListsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value indicates the token that is used for the next request to retrieve a new page of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The information about the prefix lists.</para>
        /// </summary>
        [NameInMap("PrefixLists")]
        [Validation(Required=false)]
        public List<ListPrefixListsResponseBodyPrefixLists> PrefixLists { get; set; }
        public class ListPrefixListsResponseBodyPrefixLists : TeaModel {
            /// <summary>
            /// <para>The CIDR block specified in the prefix list.</para>
            /// </summary>
            [NameInMap("CidrBlocks")]
            [Validation(Required=false)]
            public List<string> CidrBlocks { get; set; }

            /// <summary>
            /// <para>The time when the prefix list was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-12T14:22:32Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The IP version of the prefix list. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IPV4</b></description></item>
            /// <item><description><b>IPV6</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IPV4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <para>The maximum number of CIDR blocks that you can specify in the prefix list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxEntries")]
            [Validation(Required=false)]
            public int? MaxEntries { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account to which the prefix list belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1210123456123456</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The description of the prefix list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Created with oss service by system.</para>
            /// </summary>
            [NameInMap("PrefixListDescription")]
            [Validation(Required=false)]
            public string PrefixListDescription { get; set; }

            /// <summary>
            /// <para>The ID of the prefix list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pl-m5estsqsdqwg88hjf****</para>
            /// </summary>
            [NameInMap("PrefixListId")]
            [Validation(Required=false)]
            public string PrefixListId { get; set; }

            /// <summary>
            /// <para>The name of the prefix list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("PrefixListName")]
            [Validation(Required=false)]
            public string PrefixListName { get; set; }

            /// <summary>
            /// <para>The status of the prefix list. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Created</b></description></item>
            /// <item><description><b>Deleted</b></description></item>
            /// <item><description><b>Modifying</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is the same as the <b>Status</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("PrefixListStatus")]
            [Validation(Required=false)]
            public string PrefixListStatus { get; set; }

            /// <summary>
            /// <para>The type of the prefix list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("PrefixListType")]
            [Validation(Required=false)]
            public string PrefixListType { get; set; }

            /// <summary>
            /// <para>The region ID of the prefix list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the prefix list belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-bp67acfmxazb4ph****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether the prefix list is shared. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Shared</b>: The prefix list is shared.</description></item>
            /// <item><description>If an empty value is returned, the prefix list is not shared.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Shared</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// <para>The status of the prefix list. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Created</b></description></item>
            /// <item><description><b>Deleted</b></description></item>
            /// <item><description><b>Modifying</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListPrefixListsResponseBodyPrefixListsTags> Tags { get; set; }
            public class ListPrefixListsResponseBodyPrefixListsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DF72F7BB-5DFA-529C-887E-B0BB70D89C4F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
