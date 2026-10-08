// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeKmsAssociateResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of associated ApsaraDB RDS instances.</para>
        /// </summary>
        [NameInMap("AssociateDBInstances")]
        [Validation(Required=false)]
        public List<DescribeKmsAssociateResourcesResponseBodyAssociateDBInstances> AssociateDBInstances { get; set; }
        public class DescribeKmsAssociateResourcesResponseBodyAssociateDBInstances : TeaModel {
            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pgm-bp16p6f68130****</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The database engine. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MySQL</b></description></item>
            /// <item><description><b>SQLServer</b></description></item>
            /// <item><description><b>PostgreSQL</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PostgreSQL</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The purpose of the key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DiskEncryption</b>: cloud disk data encryption.</description></item>
            /// <item><description><b>TDE</b>: transparent data encryption.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DiskEncryption</para>
            /// </summary>
            [NameInMap("KeyUsedBy")]
            [Validation(Required=false)]
            public string KeyUsedBy { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CREATING</b>: The instance is being created.</description></item>
            /// <item><description><b>ACTIVATION</b>: The instance is running.</description></item>
            /// <item><description><b>DELETING</b>: The instance is being deleted.</description></item>
            /// <item><description><b>RESTARTING</b>: The instance is being restarted.</description></item>
            /// <item><description><b>CLASS_CHANGING</b>: The instance specifications are being changed.</description></item>
            /// <item><description><b>INS_MAINTAINING</b>: The instance is being maintained.</description></item>
            /// <item><description><b>BACKUP_RECOVERING</b>: A backup is being restored.</description></item>
            /// <item><description><b>NET_MODIFYING</b>: The network is being changed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVATION</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether associated ApsaraDB RDS instances exist.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Associated instances exist.</description></item>
        /// <item><description><b>false</b>: No associated instances exist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AssociateStatus")]
        [Validation(Required=false)]
        public bool? AssociateStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38F6B598-A6D7-508A-8401-12BB9936****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
