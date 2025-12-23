// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListFunctionInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;PAAS&quot;</para>
        /// </summary>
        [NameInMap("functionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        /// <summary>
        /// <para>The type of the model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tf_checkpoint</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The richness of the returned information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: displays information such as createParameters and cron. This is the default value.</description></item>
        /// <item><description>simple: displays only the basic information.</description></item>
        /// <item><description>detail: returns the details of the training task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>How the instance is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>builtin: The instance is created by system.</description></item>
        /// <item><description>user: The instance is created by user. This is the default value.</description></item>
        /// <item><description>all: all instances</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
