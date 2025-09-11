// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class CreateDatasetRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7AAB95D-*****-****-*4FC0C976</para>
        /// </summary>
        [NameInMap("DsId")]
        [Validation(Required=false)]
        public string DsId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>st_trd_user_purchase_day_inc</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>asah-fsdfsf*****92342</para>
        /// </summary>
        [NameInMap("TargetDirectoryId")]
        [Validation(Required=false)]
        public string TargetDirectoryId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserDefineCubeName")]
        [Validation(Required=false)]
        public string UserDefineCubeName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>726bee5a-****-43e1-9a8e-b550f0120f35</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>726bee5a-****-43e1-9a8e-b550f0120f35</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
