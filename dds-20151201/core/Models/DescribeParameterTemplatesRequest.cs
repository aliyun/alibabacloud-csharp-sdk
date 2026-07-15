// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeParameterTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The database engine. Set the value to <b>mongodb</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mongodb</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database version number. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>7.0</b></para>
        /// </description></item>
        /// <item><description><para><b>6.0</b></para>
        /// </description></item>
        /// <item><description><para><b>5.0</b></para>
        /// </description></item>
        /// <item><description><para><b>4.4</b></para>
        /// </description></item>
        /// <item><description><para><b>4.2</b></para>
        /// </description></item>
        /// <item><description><para><b>4.0</b></para>
        /// </description></item>
        /// <item><description><para><b>3.4</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The role of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>db: the shard role of a sharded cluster instance.</para>
        /// </description></item>
        /// <item><description><para>cs: the config server role of a sharded cluster instance.</para>
        /// </description></item>
        /// <item><description><para>mongos: the mongos role of a sharded cluster instance.</para>
        /// </description></item>
        /// <item><description><para>normal: the role of a replica set instance.</para>
        /// </description></item>
        /// <item><description><para>physical: the role of a single node instance.</para>
        /// </description></item>
        /// </list>
        /// <para>The default value is normal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

    }

}
