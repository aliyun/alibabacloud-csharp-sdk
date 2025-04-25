// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDirectoriesRequest : TeaModel {
        /// <summary>
        /// <para>Details of directory IDs. You can specify one or more directory IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-gx2x1dhsmu52rd****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public List<string> DirectoryId { get; set; }

        /// <summary>
        /// <para>The directory status. This parameter is equivalent to <c>Status</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REGISTERED</para>
        /// </summary>
        [NameInMap("DirectoryStatus")]
        [Validation(Required=false)]
        public string DirectoryStatus { get; set; }

        /// <summary>
        /// <para>The directory type.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>SIMPLE: the convenience directory.</description></item>
        /// <item><description>AD_CONNECTOR: the Active Directory (AD) directory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RAM</para>
        /// </summary>
        [NameInMap("DirectoryType")]
        [Validation(Required=false)]
        public string DirectoryType { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the next query. If this parameter is empty, all results are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The directory status.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>REGISTERING: The directory is being registered.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>DEREGISTERING: The directory is being deregistered.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>REGISTERED: The directory is registered.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>NEEDCONFIGTRUST: A trust relationship needs to be configured for the directory.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>CONFIGTRUSTFAILED: A trust relationship fails to be configured for the directory.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>DEREGISTERED: The directory is deregistered.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>ERROR: One or more configurations of the directory are invalid.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>CONFIGTRUSTING: A trust relationship is being configured.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>NEEDCONFIGUSER: Users need to be configured for the directory.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>REGISTERED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
