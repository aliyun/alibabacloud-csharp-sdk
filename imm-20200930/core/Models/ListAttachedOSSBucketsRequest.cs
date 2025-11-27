// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListAttachedOSSBucketsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of tasks in the returned result list. The value range is (0, 200], with a default value of 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>Pagination token.</para>
        /// <para>When the total number of files exceeds the set MaxResults, this token is used for pagination. It returns the list of file information in lexicographical order starting from NextToken.</para>
        /// <remarks>
        /// <para>When calling this interface for the first time in a single query, set this value to empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg6aW1tdGVzdDpleGFtcGxlYnVja2V0OmRhdGFzZXQwMDE6b3NzOi8vZXhhbXBsZWJ1Y2tldC9zYW1wbGVvYmplY3QxLmpwZw==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Project name, for more information on how to obtain it, see <a href="https://help.aliyun.com/document_detail/478153.html">Create Project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
