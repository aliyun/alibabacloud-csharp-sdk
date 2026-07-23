// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListFeatureConsistencyCheckJobFeatureReportsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance. To obtain the ID, see <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-********</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The item ID used for feature comparison.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9010</para>
        /// </summary>
        [NameInMap("LogItemId")]
        [Validation(Required=false)]
        public string LogItemId { get; set; }

        /// <summary>
        /// <para>The request ID used for feature comparison.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7AC05FF-EDE7-5C2B-B9AE-33D6DF4178BA</para>
        /// </summary>
        [NameInMap("LogRequestId")]
        [Validation(Required=false)]
        public string LogRequestId { get; set; }

        /// <summary>
        /// <para>The user ID used for feature comparison.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1010</para>
        /// </summary>
        [NameInMap("LogUserId")]
        [Validation(Required=false)]
        public string LogUserId { get; set; }

    }

}
