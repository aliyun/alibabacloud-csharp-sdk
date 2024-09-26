// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetSensitiveDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the sensitive data returned. The information includes totalCount and sensDatas. sensDatas includes the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>guid: the ID of the metadata of the tenant. For example, the ID of the metadata in the MaxCompute compute engine is in the Project name.Table name.Column name format.</description></item>
        /// <item><description>sensType: the type of the sensitive data.</description></item>
        /// <item><description>sensLevel: the sensitivity level of the sensitive data</description></item>
        /// </list>
        /// </summary>
        [NameInMap("SensitiveData")]
        [Validation(Required=false)]
        public Dictionary<string, object> SensitiveData { get; set; }

    }

}
