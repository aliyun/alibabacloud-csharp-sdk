// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListApiDestinationsRequest : TeaModel {
        /// <summary>
        /// <para>The prefix of the API destination name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-demo</para>
        /// </summary>
        [NameInMap("ApiDestinationNamePrefix")]
        [Validation(Required=false)]
        public string ApiDestinationNamePrefix { get; set; }

        /// <summary>
        /// <para>The connection name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connection-name</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to be returned in a call. You can use this parameter and NextToken to implement paging.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>If you set Limit and excess return values exist, this parameter is returned.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 0.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
