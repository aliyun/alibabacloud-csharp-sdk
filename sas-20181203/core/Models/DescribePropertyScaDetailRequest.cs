// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyScaDetailRequest : TeaModel {
        /// <summary>
        /// <para>The type of Asset Fingerprints to query. Default value: <b>sca</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sca</b>: middleware</description></item>
        /// <item><description><b>sca_database</b>: database</description></item>
        /// <item><description><b>sca_web</b>: web service</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not set, the default value <b>sca</b> is used, which queries Asset Fingerprints information of the middleware type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sca</para>
        /// </summary>
        [NameInMap("Biz")]
        [Validation(Required=false)]
        public string Biz { get; set; }

        /// <summary>
        /// <para>The type of middleware, database, or web service to query. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>system_service</b>: system service</description></item>
        /// <item><description><b>software_library</b>: software library</description></item>
        /// <item><description><b>docker_component</b>: container component</description></item>
        /// <item><description><b>database</b>: database</description></item>
        /// <item><description><b>web_container</b>: web container</description></item>
        /// <item><description><b>jar</b>: JAR package</description></item>
        /// <item><description><b>web_framework</b>: web framework.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>system_service</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The page number of the page to return in the query results. Default value: <b>1</b>, which indicates that the results are displayed starting from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the middleware, database, or web service.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. You do not need to specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public long? Name { get; set; }

        /// <summary>
        /// <para>The token that marks the current position from which to start reading. Leave this parameter empty to start reading from the beginning.</para>
        /// <remarks>
        /// <para>Do not specify this parameter for the first call. The response includes the NextToken value for the second call. Each subsequent response contains the NextToken value for the next call.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6k+AtdhNE3kgQEK36GujZ5on+tWdc+4WoaoMP/kUNxxxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Sets the number of Asset Fingerprints entries per page in a paged query. Default value: <b>10</b>, which indicates that 10 Asset Fingerprints entries are displayed per page.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The process ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>756</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <para>The port on which the process listens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The end of the time range for querying the process start timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1641110965</para>
        /// </summary>
        [NameInMap("ProcessStartedEnd")]
        [Validation(Required=false)]
        public long? ProcessStartedEnd { get; set; }

        /// <summary>
        /// <para>The start of the time range for querying the process start timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1641024565</para>
        /// </summary>
        [NameInMap("ProcessStartedStart")]
        [Validation(Required=false)]
        public long? ProcessStartedStart { get; set; }

        /// <summary>
        /// <para>The search condition (server name or IP address).</para>
        /// <remarks>
        /// <para>Fuzzy match is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The name of the Asset Fingerprints entry to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openssl</para>
        /// </summary>
        [NameInMap("ScaName")]
        [Validation(Required=false)]
        public string ScaName { get; set; }

        /// <summary>
        /// <para>The process name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("ScaNamePattern")]
        [Validation(Required=false)]
        public string ScaNamePattern { get; set; }

        /// <summary>
        /// <para>The version of the middleware, database, or web service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.2k</para>
        /// </summary>
        [NameInMap("ScaVersion")]
        [Validation(Required=false)]
        public string ScaVersion { get; set; }

        /// <summary>
        /// <para>The list of search criteria.</para>
        /// </summary>
        [NameInMap("SearchCriteriaList")]
        [Validation(Required=false)]
        public List<DescribePropertyScaDetailRequestSearchCriteriaList> SearchCriteriaList { get; set; }
        public class DescribePropertyScaDetailRequestSearchCriteriaList : TeaModel {
            /// <summary>
            /// <para>The name of the search criterion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The filter value of the search criterion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The content to query. Depending on the value of <b>SearchItem</b>, you need to enter different query content:</para>
        /// <list type="bullet">
        /// <item><description>If <b>SearchItem</b> is set to <b>name</b>, enter the name of the asset fingerprint as the query condition.</description></item>
        /// <item><description>If <b>SearchItem</b> is set to <b>type</b>, select the type of asset fingerprint to query. Valid values:   <list type="bullet">
        /// <item><description><b>system_service</b>: system service</description></item>
        /// <item><description><b>software_library</b>: software library</description></item>
        /// <item><description><b>docker_component</b>: container component</description></item>
        /// <item><description><b>database</b>: database</description></item>
        /// <item><description><b>web_container</b>: web container</description></item>
        /// <item><description><b>jar</b>: JAR package</description></item>
        /// <item><description><b>web_framework</b>: web framework</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The <b>SearchItem</b> and <b>SearchInfo</b> parameters must be used together. Setting only one of them has no effect. By setting both parameters, you can view all data for asset fingerprints of a specified name or type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>openssl</para>
        /// </summary>
        [NameInMap("SearchInfo")]
        [Validation(Required=false)]
        public string SearchInfo { get; set; }

        /// <summary>
        /// <para>The content of the sub-query condition. Depending on the value of <b>SearchItemSub</b>, you need to enter different query content:</para>
        /// <list type="bullet">
        /// <item><description>If <b>SearchItemSub</b> is set to <b>port</b>, enter the port as the sub-query condition.</description></item>
        /// <item><description>If <b>SearchItemSub</b> is set to <b>pid</b>, enter the process ID as the sub-query condition.</description></item>
        /// <item><description>If <b>SearchItemSub</b> is set to <b>version</b>, enter the middleware, database, or web service version as the sub-query condition.</description></item>
        /// <item><description>If <b>SearchItemSub</b> is set to <b>user</b>, enter the username as the sub-query condition.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Sub-query conditions help you search for the data list of a specific middleware, database, or web service.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.2k</para>
        /// </summary>
        [NameInMap("SearchInfoSub")]
        [Validation(Required=false)]
        public string SearchInfoSub { get; set; }

        /// <summary>
        /// <para>The type of query condition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the name of the middleware, database, or web service.</description></item>
        /// <item><description><b>type</b>: the type of the middleware, database, or web service.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The <b>SearchItem</b> and <b>SearchInfo</b> parameters must be used together. Setting only one of them has no effect. By setting both parameters, you can view all data for asset fingerprints of a specified name or type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("SearchItem")]
        [Validation(Required=false)]
        public string SearchItem { get; set; }

        /// <summary>
        /// <para>The type of sub-query condition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>port</b>: port</description></item>
        /// <item><description><b>pid</b>: process ID</description></item>
        /// <item><description><b>version</b>: version</description></item>
        /// <item><description><b>user</b>: user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>version</para>
        /// </summary>
        [NameInMap("SearchItemSub")]
        [Validation(Required=false)]
        public string SearchItemSub { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the NextToken method to retrieve asset list data. If this parameter is used, TotalCount is no longer returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Use the NextToken method.</description></item>
        /// <item><description><b>false</b>: Do not use the NextToken method.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseNextToken")]
        [Validation(Required=false)]
        public bool? UseNextToken { get; set; }

        /// <summary>
        /// <para>The user that runs the process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        /// <summary>
        /// <para>The UUID of the server on which the middleware, database, or web service is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uuid-02ebabe7-1c19-ab****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
