// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MaxComputeExportConfigurationSink : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<string> Fields { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("odpsAccessKeyId")]
        [Validation(Required=false)]
        [Obsolete]
        public string OdpsAccessKeyId { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("odpsAccessSecret")]
        [Validation(Required=false)]
        [Obsolete]
        public string OdpsAccessSecret { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxxxxxxx">http://xxxxxxxx</a></para>
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
        /// <b>Example:</b>
        /// <para>acs:ram::xxxxxxx</para>
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
        /// <para>This parameter is required.</para>
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
