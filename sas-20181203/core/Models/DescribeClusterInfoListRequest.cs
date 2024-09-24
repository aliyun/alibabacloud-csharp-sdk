// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterInfoListRequest : TeaModel {
        /// <summary>
        /// <para>The operation value. The value specifies the ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c23551de6149343e8a54e69fbefe6****</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The dimension based on which you want to configure the feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cluster</b>: the ID of the cluster</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The type of the feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>containerNetwork</b>: container network</description></item>
        /// <item><description><b>interceptionSwitch</b>: cluster microsegmentation</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>containerNetwork</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
