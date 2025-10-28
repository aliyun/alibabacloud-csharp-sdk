// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ScaleInApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can call the ListApplication operation to query the application ID. For more information, see <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3616cdca-4f92-44***********************</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the elastic compute container (ECC) that corresponds to the Elastic Compute Service (ECS) instance to be removed for the application. Separate multiple ECC IDs with commas (,). You can call the QueryApplicationStatus operation to query the ECC ID. For more information, see <a href="https://help.aliyun.com/document_detail/149394.html">QueryApplicationStatus</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7040f221-42df-48e8-9*******************</para>
        /// </summary>
        [NameInMap("EccInfo")]
        [Validation(Required=false)]
        public string EccInfo { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly unpublish the application from the ECS instance. You need to set this parameter to true only if the ECS instance expires. In normal cases, you do not need to set this parameter to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceStatus")]
        [Validation(Required=false)]
        public bool? ForceStatus { get; set; }

    }

}
