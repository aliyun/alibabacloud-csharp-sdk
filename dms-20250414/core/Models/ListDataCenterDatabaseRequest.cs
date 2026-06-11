// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataCenterDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is for internal use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Frontend only</para>
        /// </summary>
        [NameInMap("CallFrom")]
        [Validation(Required=false)]
        public string CallFrom { get; set; }

        /// <summary>
        /// <para>The DMS unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DmsUnit")]
        [Validation(Required=false)]
        public string DmsUnit { get; set; }

        /// <summary>
        /// <para>The import type.</para>
        /// <list type="bullet">
        /// <item><description>FILE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FILE</para>
        /// </summary>
        [NameInMap("ImportType")]
        [Validation(Required=false)]
        public string ImportType { get; set; }

        /// <summary>
        /// <para>This parameter is for internal use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Frontend only</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The keyword for a fuzzy search for databases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

    }

}
