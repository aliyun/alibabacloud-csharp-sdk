// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstanceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp11483712c1****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The database engine. Set the value to <b>MongoDB</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MongoDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is deleted. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: The instance is running. Queries the information of a running instance.</description></item>
        /// <item><description><b>true</b>: The instance is deleted. Queries the information of a deleted instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDelete")]
        [Validation(Required=false)]
        public bool? IsDelete { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The resource group ID. For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information of a resource group</a>.</para>
        /// <remarks>
        /// <para>This parameter is supported only on the China site.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyiu4ekp****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
