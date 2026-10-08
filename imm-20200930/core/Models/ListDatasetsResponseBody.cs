// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListDatasetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of dataset information.</para>
        /// </summary>
        [NameInMap("Datasets")]
        [Validation(Required=false)]
        public List<Dataset> Datasets { get; set; }

        /// <summary>
        /// <para>The pagination token. If the total number of datasets exceeds the value of MaxResults, this token is used for pagination. This parameter is returned only when not all matching datasets are returned.</para>
        /// <para>Pass this value as NextToken in the next request to return the remaining datasets.</para>
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
