// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListDiagnosticResultsRequest : TeaModel {
        /// <summary>
        /// <para>The diagnostic type. This parameter is required. If you do not specify this parameter, the API returns a 400 error (field required).</para>
        /// 
        /// <b>Example:</b>
        /// <para>NetDiag</para>
        /// </summary>
        [NameInMap("DiagType")]
        [Validation(Required=false)]
        public string DiagType { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page during paging in a paged query. Valid values: 1 to 100. If you do not specify this parameter in the Settings, the default value is 10. If the specified value is greater than 100, the value 100 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set the value to the NextToken value returned from the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a3f2224a5ec7224116c4f5246120****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmywpvugk****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
