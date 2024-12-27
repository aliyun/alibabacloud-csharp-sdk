// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListDatasetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of datasets.</para>
        /// </summary>
        [NameInMap("Datasets")]
        [Validation(Required=false)]
        public List<Dataset> Datasets { get; set; }

        /// <summary>
        /// <para>The pagination token. If the total number of datasets is greater than the value of MaxResults, you must specify this parameter. This parameter has a value only if not all the datasets that meet the conditions are returned.</para>
        /// <para>Pass this value as the value of NextToken in the next call to query subsequent datasets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678:immtest:dataset002</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEEDE356-C928-4A36-951A-6EB5A592****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
