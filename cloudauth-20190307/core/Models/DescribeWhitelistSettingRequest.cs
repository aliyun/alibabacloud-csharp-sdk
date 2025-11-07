// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeWhitelistSettingRequest : TeaModel {
        /// <summary>
        /// <para>ID Number</para>
        /// 
        /// <b>Example:</b>
        /// <para>320321XXXXXXXX701X</para>
        /// </summary>
        [NameInMap("CertNo")]
        [Validation(Required=false)]
        public string CertNo { get; set; }

        /// <summary>
        /// <para>Certification ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>shsf57a4e0d9981c3bd66dc754f3d3cd</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        /// <summary>
        /// <para>Pagination parameter: current page number, default value is 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specify the language to query. Values:</para>
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
        /// <para>Number of items per page for pagination.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Scene ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000004530</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <para>Service Code:</para>
        /// <list type="bullet">
        /// <item><description><b>Enhanced Financial Grade</b>: cloudauthst</description></item>
        /// <item><description><b>Financial Grade</b>: antcloudauth</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>antcloudauth</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>Visitor\&quot;s source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113.140.85.74</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>Whitelist status:</para>
        /// <list type="bullet">
        /// <item><description><b>VALID</b>: Valid</description></item>
        /// <item><description><b>INVALID</b>: Invalid</description></item>
        /// <item><description><b>DELETED</b>: Deleted</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VALID</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Expiration date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1730304000000</para>
        /// </summary>
        [NameInMap("ValidEndDate")]
        [Validation(Required=false)]
        public long? ValidEndDate { get; set; }

        /// <summary>
        /// <para>Effective start time (in seconds timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1759939200000</para>
        /// </summary>
        [NameInMap("ValidStartDate")]
        [Validation(Required=false)]
        public long? ValidStartDate { get; set; }

    }

}
