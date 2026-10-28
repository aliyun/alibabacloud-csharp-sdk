// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateFeatureConsistencyCheckJobRequest : TeaModel {
        /// <summary>
        /// <para>The runtime environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Daily: daily environment</description></item>
        /// <item><description>Pre: staging environment</description></item>
        /// <item><description>Prod: production environment</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pre</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <para>The feature consistency check job configuration ID. For information about how to obtain the configuration ID, see <a href="https://help.aliyun.com/document_detail/2557567.html">ListFeatureConsistencyCheckJobConfigs</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("FeatureConsistencyCheckJobConfigId")]
        [Validation(Required=false)]
        public string FeatureConsistencyCheckJobConfigId { get; set; }

        /// <summary>
        /// <para>The instance ID. For information about how to obtain the instance ID, see <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-********</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The sampling duration in minutes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SamplingDuration")]
        [Validation(Required=false)]
        public int? SamplingDuration { get; set; }

    }

}
