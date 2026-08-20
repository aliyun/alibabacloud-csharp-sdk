// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The architecture of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/86132.html">Architecture overview</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>logic</b>: cluster or read/write splitting architecture.</description></item>
        /// <item><description><b>normal</b>: standard architecture (primary/secondary).</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;If <b>EngineVersion</b> is set to <b>6.0</b>, this parameter does not support the value <b>logic</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logic</para>
        /// </summary>
        [NameInMap("CharacterType")]
        [Validation(Required=false)]
        public string CharacterType { get; set; }

        /// <summary>
        /// <para>The database type. Set the value to <b>Redis</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Redis</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The major version of the instance. Valid values: <b>4.0</b>, <b>5.0</b>, <b>6.0</b>, and <b>7.0</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/473778.html">DescribeInstances</a> operation to obtain the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The parameter category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>account</para>
        /// </summary>
        [NameInMap("ParameterCategory")]
        [Validation(Required=false)]
        public string ParameterCategory { get; set; }

        /// <summary>
        /// <para>The resource group ID. You can invoke the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to obtain the resource group ID.</para>
        /// <remarks>
        /// <para>You can also obtain the resource group ID in the console. For more information, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information of a resource group</a>.</para>
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
