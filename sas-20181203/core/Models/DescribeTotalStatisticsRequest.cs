// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTotalStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The source of data. Default value: <b>aqs</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sas</b>: Security Center</description></item>
        /// <item><description><b>aqs</b>: Server Guard</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The ID of the asset group.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/130972.html">DescribeAllGroups</a> operation to query the IDs of asset groups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8076980</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The name or public IP address of the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>222.185.XX.XX</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
