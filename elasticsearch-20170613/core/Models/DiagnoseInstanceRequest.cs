// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DiagnoseInstanceRequest : TeaModel {
        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The diagnostic items.</para>
        /// </summary>
        [NameInMap("diagnoseItems")]
        [Validation(Required=false)]
        public List<string> DiagnoseItems { get; set; }

        /// <summary>
        /// <para>The list of indexes to diagnose.</para>
        /// </summary>
        [NameInMap("indices")]
        [Validation(Required=false)]
        public List<string> Indices { get; set; }

        /// <summary>
        /// <para>The type of the diagnostic task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL: Diagnoses all indexes.</description></item>
        /// <item><description>SELECT: Diagnoses selected indexes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The language of the report. Default value: browser language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>en: English</description></item>
        /// <item><description>zh: Simplified Chinese</description></item>
        /// <item><description>zt: Traditional Chinese</description></item>
        /// <item><description>es: Spanish</description></item>
        /// <item><description>fr: French.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
