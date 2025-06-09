// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MaxComputeExportConfigurationSink : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("bufferInterval")]
        [Validation(Required=false)]
        public string BufferInterval { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("filterInvalid")]
        [Validation(Required=false)]
        public bool? FilterInvalid { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>asdfghjk</para>
        /// </summary>
        [NameInMap("odpsAccessKeyId")]
        [Validation(Required=false)]
        [Obsolete]
        public string OdpsAccessKeyId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>esasdfghjkl</para>
        /// </summary>
        [NameInMap("odpsAccessSecret")]
        [Validation(Required=false)]
        [Obsolete]
        public string OdpsAccessSecret { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api">http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api</a></para>
        /// </summary>
        [NameInMap("odpsEndpoint")]
        [Validation(Required=false)]
        public string OdpsEndpoint { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_project</para>
        /// </summary>
        [NameInMap("odpsProject")]
        [Validation(Required=false)]
        public string OdpsProject { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789:role/aliyunlogdefaultrole</para>
        /// </summary>
        [NameInMap("odpsRolearn")]
        [Validation(Required=false)]
        public string OdpsRolearn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_table</para>
        /// </summary>
        [NameInMap("odpsTable")]
        [Validation(Required=false)]
        public string OdpsTable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://dt.cn-hangzhou.maxcompute.aliyun-inc.com">http://dt.cn-hangzhou.maxcompute.aliyun-inc.com</a></para>
        /// </summary>
        [NameInMap("odpsTunnelEndpoint")]
        [Validation(Required=false)]
        public string OdpsTunnelEndpoint { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("partitionColumn")]
        [Validation(Required=false)]
        public List<string> PartitionColumn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>%Y_%m_%d</para>
        /// </summary>
        [NameInMap("partitionTimeFormat")]
        [Validation(Required=false)]
        public string PartitionTimeFormat { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>StrfTimeFormat</para>
        /// </summary>
        [NameInMap("timeFormatType")]
        [Validation(Required=false)]
        public string TimeFormatType { get; set; }

        /// <summary>
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
