// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListAccessConfigurationsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the folder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The filter condition.</para>
        /// <para>The format is <c>&lt;Attribute&gt; &lt;Operator&gt; &lt;Value&gt;</c> . The filter is not case-sensitive. The <c>&lt;Attribute&gt;</c> only supports <c>AccessConfigurationName</c>. The <c>&lt;Operator&gt;</c> only supports <c>eq</c> (equal to) and <c>sw</c> (starts with).</para>
        /// <para>Examples:</para>
        /// <para>If you configure this parameter to <c>AccessConfigurationName sw test</c>, the system queries all access configurations whose names start with <c>test</c>. If you configure this parameter to <c>AccessConfigurationName eq TestAccessConfiguration</c>, the system queries the access configuration named <c>TestAccessConfiguration</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AccessConfigurationName sw test</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
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
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request.</para>
        /// <para>If the number of results exceeds the value of <c>MaxResults</c>, the response is truncated. The <c>IsTruncated</c> parameter is set to <c>true</c>, and a <c>NextToken</c> is returned. You can use the <c>NextToken</c> in a subsequent request with the same parameters to retrieve the next page of results. Repeat this process until <c>IsTruncated</c> is <c>false</c> to query all results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>K1c3o9K7pFxoTtxH1Nm7MMLb7zrDGvftYBQBPDVv7AD3a8yhRb3Mk8L9ivmN6bFSjfkZNTAg3h4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The status notification, which is used as a filter condition.</para>
        /// <para>A value of ReprovisionRequired returns only the access configurations that need to be reprovisioned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ReprovisionRequired</para>
        /// </summary>
        [NameInMap("StatusNotifications")]
        [Validation(Required=false)]
        public string StatusNotifications { get; set; }

        /// <summary>
        /// <para>The tags attached to the access configuration.</para>
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
