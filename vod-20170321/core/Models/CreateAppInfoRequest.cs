// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateAppInfoRequest : TeaModel {
        /// <summary>
        /// <para>The application name. The name must be unique.</para>
        /// <list type="bullet">
        /// <item><description>The name can be up to 128 characters in length and can contain Chinese characters, letters, digits, periods (.), hyphens (-), and at signs (@).</description></item>
        /// <item><description>UTF-8 encoding.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The application description.</para>
        /// <list type="bullet">
        /// <item><description>The description can be up to 512 characters in length.</description></item>
        /// <item><description>UTF-8 encoding.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>myfirstapp</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzko7fsuj****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
