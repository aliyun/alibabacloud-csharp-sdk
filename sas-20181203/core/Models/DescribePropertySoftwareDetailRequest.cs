// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertySoftwareDetailRequest : TeaModel {
        /// <summary>
        /// <para>Set which page of the returned results to start displaying the query results. The default value is <b>1</b>, indicating that the display starts from the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Whether the software name supports fuzzy search. To enable fuzzy search, set the value of this parameter to 1; other values or an empty value indicate that fuzzy search is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The timestamp when the software update ended. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1650012695000</para>
        /// </summary>
        [NameInMap("InstallTimeEnd")]
        [Validation(Required=false)]
        public long? InstallTimeEnd { get; set; }

        /// <summary>
        /// <para>The timestamp when the software update started. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649321495000</para>
        /// </summary>
        [NameInMap("InstallTimeStart")]
        [Validation(Required=false)]
        public long? InstallTimeStart { get; set; }

        /// <summary>
        /// <para>The name of the software to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kernel</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Used to mark the starting position for reading. Leave it blank to start from the beginning.</para>
        /// <remarks>
        /// <para>For the first call, you do not need to fill this in; the response will include the NextToken for the second call, and each subsequent call\&quot;s response will contain the NextToken for the next call.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>E17B501887A2D3AA5E8360A6EFA3B***</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Set the number of software asset fingerprint information items displayed per page during pagination. The default value is <b>10</b>, indicating that 10 items of software asset fingerprint information are displayed per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The installation path of the software.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/etc/test</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The name or IP address of the server to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The version information of the software.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.10.0</para>
        /// </summary>
        [NameInMap("SoftwareVersion")]
        [Validation(Required=false)]
        public string SoftwareVersion { get; set; }

        /// <summary>
        /// <para>Whether to use the NextToken method to pull asset list data. If this parameter is used, TotalCount will no longer be returned. Values:</para>
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
        /// <para>The UUID of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50d213b4-3a35-427a-b8a5-****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
