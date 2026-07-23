// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class SyncFeatureConsistencyCheckJobReplayLogRequest : TeaModel {
        /// <summary>
        /// <para>The context features.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;Value\&quot;:{\&quot;FloatFeature\&quot;:0.1}}]</para>
        /// </summary>
        [NameInMap("ContextFeatures")]
        [Validation(Required=false)]
        public string ContextFeatures { get; set; }

        /// <summary>
        /// <para>The feature consistency check job configuration ID. To obtain this ID, see <a href="https://help.aliyun.com/document_detail/2557567.html">ListFeatureConsistencyCheckJobConfigs</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("FeatureConsistencyCheckJobConfigId")]
        [Validation(Required=false)]
        public string FeatureConsistencyCheckJobConfigId { get; set; }

        /// <summary>
        /// <para>The generated features.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>week_day:1 | userid:3 | itemid:9001 | cate:cat1 | click_5_seq__cate:cat1</para>
        /// </summary>
        [NameInMap("GeneratedFeatures")]
        [Validation(Required=false)]
        public string GeneratedFeatures { get; set; }

        /// <summary>
        /// <para>The instance ID. To obtain this ID, see <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-********</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The item ID from the log.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9010</para>
        /// </summary>
        [NameInMap("LogItemId")]
        [Validation(Required=false)]
        public string LogItemId { get; set; }

        /// <summary>
        /// <para>The request ID from the log.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("LogRequestId")]
        [Validation(Required=false)]
        public string LogRequestId { get; set; }

        /// <summary>
        /// <para>The request time from the log, provided as a UNIX epoch timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1693900981465</para>
        /// </summary>
        [NameInMap("LogRequestTime")]
        [Validation(Required=false)]
        public long? LogRequestTime { get; set; }

        /// <summary>
        /// <para>The user ID from the log.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1010</para>
        /// </summary>
        [NameInMap("LogUserId")]
        [Validation(Required=false)]
        public string LogUserId { get; set; }

        /// <summary>
        /// <para>The raw features.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>author__kv_city_expr_cnt_15d：北京市 | tem__min_age_15d:28</para>
        /// </summary>
        [NameInMap("RawFeatures")]
        [Validation(Required=false)]
        public string RawFeatures { get; set; }

        /// <summary>
        /// <para>The scene name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video-feed</para>
        /// </summary>
        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

    }

}
