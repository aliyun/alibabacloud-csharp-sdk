// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MaxComputeExportConfigurationSink : TeaModel {
        /// <summary>
        /// <para>Specifies the minimum time granularity between two data shipping jobs. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1800 (default)</description></item>
        /// <item><description>3600</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("bufferInterval")]
        [Validation(Required=false)]
        public string BufferInterval { get; set; }

        /// <summary>
        /// <para>The fields that you want to ship.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter the invalid content.</para>
        /// <list type="bullet">
        /// <item><description>true (default)</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("filterInvalid")]
        [Validation(Required=false)]
        public bool? FilterInvalid { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The AccessKey ID used to write data to MaxCompute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>axxxxxxxxxxxb</para>
        /// </summary>
        [NameInMap("odpsAccessKeyId")]
        [Validation(Required=false)]
        [Obsolete]
        public string OdpsAccessKeyId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The AccessKey secret used to write data to MaxCompute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aaxxxxxxxxxxxxxxxxxxxxxbb</para>
        /// </summary>
        [NameInMap("odpsAccessSecret")]
        [Validation(Required=false)]
        [Obsolete]
        public string OdpsAccessSecret { get; set; }

        /// <summary>
        /// <para>The endpoint of MaxCompute.</para>
        /// <list type="bullet">
        /// <item><description>⚠️Note: The endpoint of MaxCompute must be the same as that of the Simple Log Service project.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://service.cn-hangzhou-intranet.maxcompute.aliyun-inc.com/api">https://service.cn-hangzhou-intranet.maxcompute.aliyun-inc.com/api</a></para>
        /// </summary>
        [NameInMap("odpsEndpoint")]
        [Validation(Required=false)]
        public string OdpsEndpoint { get; set; }

        /// <summary>
        /// <para>The name of the MaxCompute project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_project</para>
        /// </summary>
        [NameInMap("odpsProject")]
        [Validation(Required=false)]
        public string OdpsProject { get; set; }

        /// <summary>
        /// <para>The Resource Access Management (RAM) role the data shipping job assumes to write data to MaxCompute.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::xxxxxxx</para>
        /// </summary>
        [NameInMap("odpsRolearn")]
        [Validation(Required=false)]
        public string OdpsRolearn { get; set; }

        /// <summary>
        /// <para>The name of the MaxCompute table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_table</para>
        /// </summary>
        [NameInMap("odpsTable")]
        [Validation(Required=false)]
        public string OdpsTable { get; set; }

        /// <summary>
        /// <para>The Tunnel endpoint of MaxCompute.</para>
        /// <list type="bullet">
        /// <item><description>⚠️Note: The Tunnel endpoint of MaxCompute must be the same as that of the Simple Log Service project.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://dt.cn-hangzhou-intranet.maxcompute.aliyun-inc.com">https://dt.cn-hangzhou-intranet.maxcompute.aliyun-inc.com</a></para>
        /// </summary>
        [NameInMap("odpsTunnelEndpoint")]
        [Validation(Required=false)]
        public string OdpsTunnelEndpoint { get; set; }

        /// <summary>
        /// <para>The partition key columns that you want to ship.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("partitionColumn")]
        [Validation(Required=false)]
        public List<string> PartitionColumn { get; set; }

        /// <summary>
        /// <para>The time partition format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>%Y_%m_%d</para>
        /// </summary>
        [NameInMap("partitionTimeFormat")]
        [Validation(Required=false)]
        public string PartitionTimeFormat { get; set; }

        /// <summary>
        /// <para>The time partition type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>StrfTimeFormat (default)</description></item>
        /// <item><description>JavaSimpleDateFormat</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>StrfTimeFormat</para>
        /// </summary>
        [NameInMap("timeFormatType")]
        [Validation(Required=false)]
        public string TimeFormatType { get; set; }

        /// <summary>
        /// <para>The time zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>+0800</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
