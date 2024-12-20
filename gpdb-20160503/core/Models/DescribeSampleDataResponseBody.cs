// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSampleDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The error message returned if an error occurs. This message does not affect the execution of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Indicates whether a sample dataset is loaded to the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: A sample dataset is loaded.</description></item>
        /// <item><description><b>false</b>: No sample dataset is loaded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasSampleData")]
        [Validation(Required=false)]
        public bool? HasSampleData { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84CD7CAF-FA7B-5178-B19F-D8CDE307D5FA_8111</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The loading status of the sample dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>loaded</b></description></item>
        /// <item><description><b>loading</b></description></item>
        /// <item><description><b>unload</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>loaded</para>
        /// </summary>
        [NameInMap("SampleDataStatus")]
        [Validation(Required=false)]
        public string SampleDataStatus { get; set; }

    }

}
