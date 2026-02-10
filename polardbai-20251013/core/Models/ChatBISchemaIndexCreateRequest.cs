// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PolardbAI20251013.Models
{
    public class ChatBISchemaIndexCreateRequest : TeaModel {
        [NameInMap("AuthMessage")]
        [Validation(Required=false)]
        public string AuthMessage { get; set; }

        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>空字符串, \&quot;graph_info.time,text_info.ext\&quot;</para>
        /// </summary>
        [NameInMap("ColumnsExcluded")]
        [Validation(Required=false)]
        public string ColumnsExcluded { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_test</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze454l20me07****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>空字符串</para>
        /// </summary>
        [NameInMap("TableNameSuffix")]
        [Validation(Required=false)]
        public string TableNameSuffix { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>空字符串, \&quot;graph_info,image_info,text_info\&quot;</para>
        /// </summary>
        [NameInMap("TablesIncluded")]
        [Validation(Required=false)]
        public string TablesIncluded { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0,1</para>
        /// </summary>
        [NameInMap("ToSample")]
        [Validation(Required=false)]
        public int? ToSample { get; set; }

    }

}
