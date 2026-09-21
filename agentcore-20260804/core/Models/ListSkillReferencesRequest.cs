// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListSkillReferencesRequest : TeaModel {
        /// <summary>
        /// <para>The page number, starting from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. If this parameter is not specified, the server-side default value is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters results by reference selector type. Valid values: LABEL and VERSION.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LABEL</para>
        /// </summary>
        [NameInMap("selectorType")]
        [Validation(Required=false)]
        public string SelectorType { get; set; }

        /// <summary>
        /// <para>Filters results by reference selector value, such as latest, a named label, HEAD, or a specific version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HEAD</para>
        /// </summary>
        [NameInMap("selectorValue")]
        [Validation(Required=false)]
        public string SelectorValue { get; set; }

    }

}
