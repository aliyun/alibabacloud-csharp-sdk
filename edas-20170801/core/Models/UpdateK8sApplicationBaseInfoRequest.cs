// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateK8sApplicationBaseInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f038ddf-b27b-<b><b>-</b></b>-88e44375****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The description of the application. The description can be up to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app for pre-production</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The email address of the application owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:mymail@example.com">mymail@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The owner of the application. The value can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tom</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The phone number of the application owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1361234xxxx</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

    }

}
