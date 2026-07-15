// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeMongoDBLogConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the audit log feature is enabled for the ApsaraDB for MongoDB instance.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAudit")]
        [Validation(Required=false)]
        public bool? EnableAudit { get; set; }

        /// <summary>
        /// <para>The retention period of hot storage for the V2_Standard (DAS Enterprise Edition (NoSQL-compatible)) version of audit logs. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("HotTtlForV2Standard")]
        [Validation(Required=false)]
        public long? HotTtlForV2Standard { get; set; }

        /// <summary>
        /// <para>Indicates whether a rule is created to ship audit logs to Logtail. For more information about Logtail, see <a href="https://help.aliyun.com/document_detail/28979.html">What is Logtail?</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: A rule is created.</para>
        /// </description></item>
        /// <item><description><para><b>0</b> or <b>null</b>: No rule is created.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsEtlMetaExist")]
        [Validation(Required=false)]
        public int? IsEtlMetaExist { get; set; }

        /// <summary>
        /// <para>Indicates whether a Simple Log Service project for audit logs exists in the current region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: The project exists.</para>
        /// </description></item>
        /// <item><description><para><b>0</b> or <b>null</b>: The project does not exist.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsUserProjectLogstoreExist")]
        [Validation(Required=false)]
        public int? IsUserProjectLogstoreExist { get; set; }

        /// <summary>
        /// <para>The maximum storage capacity for the official version of audit logs. A value of -1 indicates that no upper limit is set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("PreserveStorageForStandard")]
        [Validation(Required=false)]
        public long? PreserveStorageForStandard { get; set; }

        /// <summary>
        /// <para>The maximum storage capacity for the free trial version of audit logs. Unit: bytes. The maximum value is 107374182400 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>107374182400</para>
        /// </summary>
        [NameInMap("PreserveStorageForTrail")]
        [Validation(Required=false)]
        public long? PreserveStorageForTrail { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>664ECE26-658A-47C5-88F6-870B0132E8D2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The version of the audit log feature.</para>
        /// <list type="bullet">
        /// <item><description><para><b>Trial</b>: Free trial version.</para>
        /// </description></item>
        /// <item><description><para><b>Standard</b>: Official version.</para>
        /// </description></item>
        /// <item><description><para><b>V2_Standard</b>: DAS Enterprise Edition (NoSQL-compatible) version.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The retention period of audit logs for the official version. The value ranges from 1 to 365. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TtlForStandard")]
        [Validation(Required=false)]
        public long? TtlForStandard { get; set; }

        /// <summary>
        /// <para>The retention period of audit logs for the free trial version. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TtlForTrail")]
        [Validation(Required=false)]
        public long? TtlForTrail { get; set; }

        /// <summary>
        /// <para>The retention period of cold storage for the V2_Standard (DAS Enterprise Edition (NoSQL-compatible)) version of audit logs. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TtlForV2Standard")]
        [Validation(Required=false)]
        public long? TtlForV2Standard { get; set; }

        /// <summary>
        /// <para>The storage capacity that is used by audit logs for the official version. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20163</para>
        /// </summary>
        [NameInMap("UsedStorageForStandard")]
        [Validation(Required=false)]
        public long? UsedStorageForStandard { get; set; }

        /// <summary>
        /// <para>The storage capacity that is used by audit logs for the free trial version. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12548178759</para>
        /// </summary>
        [NameInMap("UsedStorageForTrail")]
        [Validation(Required=false)]
        public long? UsedStorageForTrail { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service project for the audit logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nosql-176498472570****-cn-hangzhou</para>
        /// </summary>
        [NameInMap("UserProjectName")]
        [Validation(Required=false)]
        public string UserProjectName { get; set; }

    }

}
