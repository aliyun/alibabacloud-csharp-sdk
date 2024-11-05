// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeMongoDBLogConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether to enable the audit log feature.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The audit log feature is enabled.</description></item>
        /// <item><description><b>false</b>: The audit log feature is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAudit")]
        [Validation(Required=false)]
        public bool? EnableAudit { get; set; }

        /// <summary>
        /// <para>Indicates whether a rule to distribute logs to Logtail is created. For more information, see <a href="https://help.aliyun.com/document_detail/28979.html">Logtail overview</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: A rule to distribute logs to Logtail is created.</description></item>
        /// <item><description><b>0</b> or <b>null</b>: A rule to distribute logs to Logtail is not created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsEtlMetaExist")]
        [Validation(Required=false)]
        public int? IsEtlMetaExist { get; set; }

        /// <summary>
        /// <para>Indicates whether a project exists in the current region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: A logging project exists in the current region.</description></item>
        /// <item><description><b>0</b> or <b>null</b>: A logging project does not exist in the current region.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsUserProjectLogstoreExist")]
        [Validation(Required=false)]
        public int? IsUserProjectLogstoreExist { get; set; }

        /// <summary>
        /// <para>The maximum storage capacity for the formal edition of the audit log feature. If the value is -1, no maximum storage capacity is set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("PreserveStorageForStandard")]
        [Validation(Required=false)]
        public long? PreserveStorageForStandard { get; set; }

        /// <summary>
        /// <para>The maximum storage capacity for the free trial edition of the audit log feature. Unit: bytes. You can set the maximum storage capacity to 107,374,182,400 bytes.</para>
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
        /// <para>The type of the audit log feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Trail</b>: the free trial edition</description></item>
        /// <item><description><b>Standard</b>: the official edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The retention period for the official edition of the audit log feature. Valid values: 1 to 365. Unit: day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TtlForStandard")]
        [Validation(Required=false)]
        public long? TtlForStandard { get; set; }

        /// <summary>
        /// <para>The retention period for the free trial edition of the audit log feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TtlForTrail")]
        [Validation(Required=false)]
        public long? TtlForTrail { get; set; }

        /// <summary>
        /// <para>The used storage capacity for the formal edition of the audit log feature. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20163</para>
        /// </summary>
        [NameInMap("UsedStorageForStandard")]
        [Validation(Required=false)]
        public long? UsedStorageForStandard { get; set; }

        /// <summary>
        /// <para>The used storage capacity for the free trial edition of the audit log feature. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12548178759</para>
        /// </summary>
        [NameInMap("UsedStorageForTrail")]
        [Validation(Required=false)]
        public long? UsedStorageForTrail { get; set; }

        /// <summary>
        /// <para>The name of the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nosql-176498472570****-cn-hangzhou</para>
        /// </summary>
        [NameInMap("UserProjectName")]
        [Validation(Required=false)]
        public string UserProjectName { get; set; }

    }

}
