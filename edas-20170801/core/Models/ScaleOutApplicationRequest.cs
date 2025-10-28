// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ScaleOutApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application that you want to scale out. You can call the ListApplication operation to query the application ID. For more information, see <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3616cdca-4f92-4413*****************</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the instance group where the application you want to scale out is deployed. You can call the QueryApplicationStatus operation to query the group ID. For more information, see <a href="https://help.aliyun.com/document_detail/149394.html">QueryApplicationStatus</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f1fb6f5-6769-4bd6******************</para>
        /// </summary>
        [NameInMap("DeployGroup")]
        [Validation(Required=false)]
        public string DeployGroup { get; set; }

        /// <summary>
        /// <para>The ID of the elastic compute unit (ECU) that corresponds to the Elastic Compute Service (ECS) instance to be added to the instance group for scale-out. You can call the ListScaleOutEcu operation to query the ECU ID. For more information, see <a href="https://help.aliyun.com/document_detail/149371.html">ListScaleOutEcu</a>. Separate multiple ECU IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8123db90-880f-486f-b***************</para>
        /// </summary>
        [NameInMap("EcuInfo")]
        [Validation(Required=false)]
        public string EcuInfo { get; set; }

    }

}
