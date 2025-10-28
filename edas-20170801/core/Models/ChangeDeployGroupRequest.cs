// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ChangeDeployGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3616cdca-4f92-**********</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the elastic compute component (ECC) that corresponds to the ECS instance for which you want to change the application instance group. You can call the ListApplicationEcc operation to query the ECC ID. For more information, see <a href="https://help.aliyun.com/document_detail/199277.html">ListApplicationEcc</a>.</para>
        /// <remarks>
        /// <para>You can change the application instance group for only one ECS instance at a time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0cf49a6c-95a8-4aa8******</para>
        /// </summary>
        [NameInMap("EccInfo")]
        [Validation(Required=false)]
        public string EccInfo { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly change the application instance group if the deployment package version of the ECC is different from that of the application instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceStatus")]
        [Validation(Required=false)]
        public bool? ForceStatus { get; set; }

        /// <summary>
        /// <para>The name of the application instance group. Examples: group_a and group_b. The parameter value for the default application instance group is <c>_DEFAULT_GROUP</c>. The name can be up to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

    }

}
