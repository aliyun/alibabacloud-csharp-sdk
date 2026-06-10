// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppMaterialDirectory : TeaModel {
        /// <summary>
        /// <para>Application instance business ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250814102215000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>List of subfolders</para>
        /// </summary>
        [NameInMap("Children")]
        [Validation(Required=false)]
        public List<AppMaterialDirectory> Children { get; set; }

        /// <summary>
        /// <para>Folder ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20260206134746000001-system</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>图片管理</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Sorting number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SortNum")]
        [Validation(Required=false)]
        public string SortNum { get; set; }

        /// <summary>
        /// <para>Folder type</para>
        /// 
        /// <b>Example:</b>
        /// <para>CUSTOM</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
