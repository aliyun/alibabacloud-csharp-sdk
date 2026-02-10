// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyScaDetailRequest : TeaModel {
        /// <summary>
        /// <para>The type of the asset fingerprint that you want to query. Default value: <b>sca</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sca</b>: middleware</description></item>
        /// <item><description><b>sca_database</b>: database</description></item>
        /// <item><description><b>sca_web</b>: web service</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, the default value <b>sca</b> is used, which indicates that middleware fingerprints are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sca</para>
        /// </summary>
        [NameInMap("Biz")]
        [Validation(Required=false)]
        public string Biz { get; set; }

        /// <summary>
        /// <para>The type of the middleware, database, or web service that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>system_service</b>: system service</description></item>
        /// <item><description><b>software_library</b>: software library</description></item>
        /// <item><description><b>docker_component</b>: container component</description></item>
        /// <item><description><b>database</b>: database</description></item>
        /// <item><description><b>web_container</b>: web container</description></item>
        /// <item><description><b>jar</b>: JAR package</description></item>
        /// <item><description><b>web_framework</b>: web framework</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>system_service</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
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
        /// <para> This parameter is deprecated. You can ignore it.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public long? Name { get; set; }

        /// <summary>
        /// <para>The value of NextToken that is returned when the NextToken method is used. You do not need to specify this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6k+AtdhNE3kgQEK36GujZ5on+tWdc+4WoaoMP/kUNxxxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>.</para>
        /// <remarks>
        /// <para> We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The PID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>756</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <para>The port that the process monitors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The timestamp when the process ends. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1641110965</para>
        /// </summary>
        [NameInMap("ProcessStartedEnd")]
        [Validation(Required=false)]
        public long? ProcessStartedEnd { get; set; }

        /// <summary>
        /// <para>The timestamp when the process starts. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1641024565</para>
        /// </summary>
        [NameInMap("ProcessStartedStart")]
        [Validation(Required=false)]
        public long? ProcessStartedStart { get; set; }

        /// <summary>
        /// <para>The search condition, such as a server name or a server IP address.</para>
        /// <remarks>
        /// <para> Fuzzy match is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The name of the asset fingerprint that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openssl</para>
        /// </summary>
        [NameInMap("ScaName")]
        [Validation(Required=false)]
        public string ScaName { get; set; }

        /// <summary>
        /// <para>The name of the process.</para>
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

        [NameInMap("SearchCriteriaList")]
        [Validation(Required=false)]
        public List<DescribePropertyScaDetailRequestSearchCriteriaList> SearchCriteriaList { get; set; }
        public class DescribePropertyScaDetailRequestSearchCriteriaList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The search keyword. You must specify this parameter based on the value of the <b>SearchItem</b> parameter.</para>
        /// <list type="bullet">
        /// <item><description><para>If the <b>SearchItem</b> parameter is set to <b>name</b>, you must enter the name of an asset fingerprint.</para>
        /// </description></item>
        /// <item><description><para>If the <b>SearchItem</b> parameter is set to <b>type</b>, you must enter the type of an asset fingerprint. Valid values:</para>
        /// <list type="bullet">
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
        /// <para> You must specify both the <b>SearchItem</b> and <b>SearchInfo</b> parameters before you can query the asset fingerprints based on the specified name or type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>openssl</para>
        /// </summary>
        [NameInMap("SearchInfo")]
        [Validation(Required=false)]
        public string SearchInfo { get; set; }

        /// <summary>
        /// <para>The keyword of the subquery. You must specify this parameter based on the value of the <b>SearchItemSub</b> parameter.</para>
        /// <list type="bullet">
        /// <item><description>If the <b>SearchItemSub</b> parameter is set to <b>port</b>, you must enter a port number.</description></item>
        /// <item><description>If the <b>SearchItemSub</b> parameter is set to <b>pid</b>, you must enter a process ID (PID).</description></item>
        /// <item><description>If the <b>SearchItemSub</b> parameter is set to <b>version</b>, you must enter the version of a database, middleware, or web service.</description></item>
        /// <item><description>If the <b>SearchItemSub</b> parameter is set to <b>user</b>, you must enter a username.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The subquery is used to search for data of a specified database, middleware, or web service.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.2k</para>
        /// </summary>
        [NameInMap("SearchInfoSub")]
        [Validation(Required=false)]
        public string SearchInfoSub { get; set; }

        /// <summary>
        /// <para>The type of the search condition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the name of a database, middleware, or web service</description></item>
        /// <item><description><b>type</b>: the type of a database, middleware, or web service</description></item>
        /// </list>
        /// <remarks>
        /// <para> You must specify both the <b>SearchItem</b> and <b>SearchInfo</b> parameters before you can query the asset fingerprints based on the specified name or type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("SearchItem")]
        [Validation(Required=false)]
        public string SearchItem { get; set; }

        /// <summary>
        /// <para>The type of the subquery. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>port</b></description></item>
        /// <item><description><b>pid</b></description></item>
        /// <item><description><b>version</b></description></item>
        /// <item><description><b>user</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>version</para>
        /// </summary>
        [NameInMap("SearchItemSub")]
        [Validation(Required=false)]
        public string SearchItemSub { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the NextToken method to retrieve a new page of results. If you set UseNextToken to true, the value of TotalCount is not returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The NextToken method is used.</description></item>
        /// <item><description><b>false</b>: The NextToken method is not used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseNextToken")]
        [Validation(Required=false)]
        public bool? UseNextToken { get; set; }

        /// <summary>
        /// <para>The user who runs the process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        /// <summary>
        /// <para>The UUID of the server on which the middleware, database, or web service is run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uuid-02ebabe7-1c19-ab****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
