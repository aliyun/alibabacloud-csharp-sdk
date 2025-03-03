// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class BackflowFeatureConsistencyCheckJobDataRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("FeatureConsistencyCheckJobConfigId")]
        [Validation(Required=false)]
        public string FeatureConsistencyCheckJobConfigId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-********</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;{\\\&quot;itemid\\\&quot;:{\\\&quot;value\\\&quot;:1010,\\\&quot;type\\\&quot;:\\\&quot;string\\\&quot;}}\&quot;]</para>
        /// </summary>
        [NameInMap("ItemFeatures")]
        [Validation(Required=false)]
        public string ItemFeatures { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9010</para>
        /// </summary>
        [NameInMap("LogItemId")]
        [Validation(Required=false)]
        public string LogItemId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("LogRequestId")]
        [Validation(Required=false)]
        public string LogRequestId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1693900981465</para>
        /// </summary>
        [NameInMap("LogRequestTime")]
        [Validation(Required=false)]
        public long? LogRequestTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1010</para>
        /// </summary>
        [NameInMap("LogUserId")]
        [Validation(Required=false)]
        public string LogUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video-feed</para>
        /// </summary>
        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;{\\\&quot;dbmtl_probs_is_valid_play\\\&quot;:0.00032182207107543945,\\\&quot;dbmtl_y_play_time\\\&quot;:0.0043269748210906982}\&quot;]</para>
        /// </summary>
        [NameInMap("Scores")]
        [Validation(Required=false)]
        public string Scores { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;userid\&quot;:{\&quot;value\&quot;:1010,\&quot;type\&quot;:\&quot;string\&quot;},\&quot;click_5_seq\&quot;:{\&quot;value\&quot;:\&quot;9001;9002;9003;9004;9005\&quot;,\&quot;type\&quot;:\&quot;string\&quot;}}</para>
        /// </summary>
        [NameInMap("UserFeatures")]
        [Validation(Required=false)]
        public string UserFeatures { get; set; }

    }

}
