// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyImageSharePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account with which you want to share the image. You can specify multiple Alibaba Cloud IDs. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1122334455**</para>
        /// </summary>
        [NameInMap("AddAccounts")]
        [Validation(Required=false)]
        public string AddAccounts { get; set; }

        /// <summary>
        /// <para>The ID of the image. You can specify only one image ID. Custom images and public images are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-5s7qotzavwbrnzaqh4unm****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account from which you want to unshare the image. You can specify only one Alibaba Cloud account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113355**</para>
        /// </summary>
        [NameInMap("RemoveAccounts")]
        [Validation(Required=false)]
        public string RemoveAccounts { get; set; }

    }

}
