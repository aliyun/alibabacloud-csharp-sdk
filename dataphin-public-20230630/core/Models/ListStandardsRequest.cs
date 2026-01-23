// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListStandardsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListStandardsRequestListQuery ListQuery { get; set; }
        public class ListStandardsRequestListQuery : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>/dir1/dir2</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("StandardSetIdList")]
            [Validation(Required=false)]
            public List<long?> StandardSetIdList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("StandardStage")]
            [Validation(Required=false)]
            public string StandardStage { get; set; }

            [NameInMap("StandardStatusList")]
            [Validation(Required=false)]
            public List<string> StandardStatusList { get; set; }

            [NameInMap("StandardTemplateIdList")]
            [Validation(Required=false)]
            public List<long?> StandardTemplateIdList { get; set; }

            [NameInMap("StandardTypeList")]
            [Validation(Required=false)]
            public List<string> StandardTypeList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
