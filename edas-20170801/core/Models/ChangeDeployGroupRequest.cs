// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ChangeDeployGroupRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3616cdca-4f92-**********</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The Elastic Compute Container (ECC) ID of the ECS instance whose group you want to change. Call the ListApplicationEcc operation to query the ECC ID of an application. For more information, see <a href="https://help.aliyun.com/document_detail/199277.html">ListApplicationEcc</a>.</para>
        /// <remarks>
        /// <para>You can change the group for only one ECS instance at a time.</para>
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
        /// <para>Specifies whether to force the change when the deployment package version of the ECC is different from the deployment package version of the application group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceStatus")]
        [Validation(Required=false)]
        public bool? ForceStatus { get; set; }

        /// <summary>
        /// <para>The name of the application group, such as \<c>group_a\\</c> and \<c>group_b\\</c>. The GroupName for the default group is <c>_DEFAULT_GROUP</c>. The name can be up to 64 characters long.</para>
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
