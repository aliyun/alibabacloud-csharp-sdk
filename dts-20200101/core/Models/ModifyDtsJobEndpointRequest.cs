// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyDtsJobEndpointRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>150780020300****</para>
        /// </summary>
        [NameInMap("AliyunUid")]
        [Validation(Required=false)]
        public string AliyunUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dtsaw012y2g15q****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>m4312mab158****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>src</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rm-bp10k50h8374w****</para>
        /// </summary>
        [NameInMap("EndpointInstanceId")]
        [Validation(Required=false)]
        public string EndpointInstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("EndpointInstanceType")]
        [Validation(Required=false)]
        public string EndpointInstanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>172.168.XX.XXX</para>
        /// </summary>
        [NameInMap("EndpointIp")]
        [Validation(Required=false)]
        public string EndpointIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("EndpointPort")]
        [Validation(Required=false)]
        public string EndpointPort { get; set; }

        [NameInMap("EndpointRegionId")]
        [Validation(Required=false)]
        public string EndpointRegionId { get; set; }

        [NameInMap("ModifyAccount")]
        [Validation(Required=false)]
        public bool? ModifyAccount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DTStest****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ram-for-dts</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DTStest****</para>
        /// </summary>
        [NameInMap("ShardPassword")]
        [Validation(Required=false)]
        public string ShardPassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>shard</para>
        /// </summary>
        [NameInMap("ShardUsername")]
        [Validation(Required=false)]
        public string ShardUsername { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
