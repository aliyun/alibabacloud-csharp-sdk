// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListAccessConfigurationsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The filter condition.</para>
        /// <para>The value is not case-sensitive. You must specify the value in the \<Attribute> \<Operator> \<Value> format. You can set \<Attribute> only to AccessConfigurationName and \<Operator> only to eq or sw. The value eq indicates Equals. The value sw indicates Starts With.</para>
        /// <para>For example, if you set Filter to AccessConfigurationName sw test, the operation queries all access configurations whose names start with test. If you set Filter to AccessConfigurationName eq TestAccessConfiguration, the operation queries the access configuration whose name is TestAccessConfiguration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AccessConfigurationName sw test</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of <c>NextToken</c>.</para>
        /// <para>When you call this operation for the first time, if the total number of entries to return is larger than the value of the <c>MaxResults</c> parameter, the entries are truncated. The system returns entries based on the value of the <c>MaxResults</c> parameter, and does not return the excess entries. In this case, the value of the response parameter <c>IsTruncated</c> is <c>true</c>, and the <c>NextToken</c> parameter is returned. In the next call, you can use the value of the <c>NextToken</c> parameter and maintain the settings of the other request parameters to query the excess entries. You can repeat the call until the value of <c>IsTruncated</c> becomes <c>false</c>. This way, all entries are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>K1c3o9K7pFxoTtxH1Nm7MMLb7zrDGvftYBQBPDVv7AD3a8yhRb3Mk8L9ivmN6bFSjfkZNTAg3h4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The status notification. The status notification can be used to filter access configurations.</para>
        /// <para>Set the value to ReprovisionRequired, which indicates that the operation queries all access configurations that need to be re-provisioned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ReprovisionRequired</para>
        /// </summary>
        [NameInMap("StatusNotifications")]
        [Validation(Required=false)]
        public string StatusNotifications { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListAccessConfigurationsRequestTags> Tags { get; set; }
        public class ListAccessConfigurationsRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
