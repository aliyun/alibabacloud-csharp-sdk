// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class CreateChatSessionRequest : TeaModel {
        /// <summary>
        /// <para>Folder ID, to search for Q&amp;A content within the current folder and its subfolders.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a851c4a-1d65-11ef-99a7-ssfsfdd</para>
        /// </summary>
        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>Name of the current session.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>analyzer_1744684195</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The unique identifier of the user. If not provided, the SDK calling account will be used as the user ID by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1233333</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
