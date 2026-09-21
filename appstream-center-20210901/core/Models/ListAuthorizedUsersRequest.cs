// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAuthorizedUsersRequest : TeaModel {
        /// <summary>
        /// <para>The application ID used to filter authorization relationships.</para>
        /// <para>Set this parameter when querying authorized users of a specific application. This parameter is not required when querying cloud browser groups or delivery group sets.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The delivery group ID. When querying cloud browsers, set this parameter to the browser group ID.</para>
        /// <para>Specify either this parameter or <c>AppInstanceGroupSetId</c>, but not both.</para>
        /// 
        /// <b>Example:</b>
        /// <para>big-3jm9d0abc00example</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The delivery group set ID.</para>
        /// <para>Specify either this parameter or <c>AppInstanceGroupId</c>, but not both. When querying by set, omit <c>AppId</c> and <c>AppInstancePersistentId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>set-3jm9d0abc00example</para>
        /// </summary>
        [NameInMap("AppInstanceGroupSetId")]
        [Validation(Required=false)]
        public string AppInstanceGroupSetId { get; set; }

        /// <summary>
        /// <para>The persistent session ID used to filter authorization relationships. This parameter applies to delivery groups that use session-based authorization.</para>
        /// <para>This parameter is not required when querying delivery group sets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ai-3jm9d0abc00example</para>
        /// </summary>
        [NameInMap("AppInstancePersistentId")]
        [Validation(Required=false)]
        public string AppInstancePersistentId { get; set; }

        /// <summary>
        /// <para>Performs an exact match by authorized username. If this parameter is not specified, results are not filtered by exact username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The page number. This parameter is required. Pages start from page 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of records per page. This parameter is required. Maximum value: 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. Set this parameter to <c>CloudBrowser</c> when querying authorized users of cloud browsers.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudBrowser</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>Performs a fuzzy match by text contained in the authorized username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali</para>
        /// </summary>
        [NameInMap("UserIdFuzzy")]
        [Validation(Required=false)]
        public string UserIdFuzzy { get; set; }

    }

}
