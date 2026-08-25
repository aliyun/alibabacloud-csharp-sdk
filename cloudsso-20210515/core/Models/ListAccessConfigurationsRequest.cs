// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListAccessConfigurationsRequest : TeaModel {
        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The filter condition.</para>
        /// <para>Format: <Attribute> <Operator> <Value>. The filter is case-insensitive. Currently, <Attribute> supports only AccessConfigurationName, and <Operator> supports only eq (Equals) and sw (Start With).</para>
        /// <para>Example: Filter = &quot;AccessConfigurationName sw test&quot; queries all access configurations whose names start with test. Filter = &quot;AccessConfigurationName eq TestAccessConfiguration&quot; queries the access configuration named TestAccessConfiguration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AccessConfigurationName sw test</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page of results. You do not need to specify <c>NextToken</c> for the first API call.</para>
        /// <para>When you call this API operation for the first time, if the total number of results exceeds the <c>MaxResults</c> limit, the results are truncated and only <c>MaxResults</c> entries are returned. In this case, the <c>IsTruncated</c> parameter is set to <c>true</c> and a <c>NextToken</c> is returned. You can use the <c>NextToken</c> returned from the previous call to continue calling this API operation while keeping other request parameters unchanged to query the truncated results. You can repeat this process until <c>IsTruncated</c> is <c>false</c>, which indicates that all data has been retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>K1c3o9K7pFxoTtxH1Nm7MMLb7zrDGvftYBQBPDVv7AD3a8yhRb3Mk8L9ivmN6bFSjfkZNTAg3h4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The status notification information, which is used as a filter condition for the query.</para>
        /// <para>Valid values: ReprovisionRequired, which queries access configurations that need to be reprovisioned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ReprovisionRequired</para>
        /// </summary>
        [NameInMap("StatusNotifications")]
        [Validation(Required=false)]
        public string StatusNotifications { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListAccessConfigurationsRequestTags> Tags { get; set; }
        public class ListAccessConfigurationsRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
