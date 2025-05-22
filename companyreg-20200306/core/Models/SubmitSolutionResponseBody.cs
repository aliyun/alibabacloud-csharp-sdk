// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Companyreg20200306.Models
{
    public class SubmitSolutionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://companyreg.console.aliyun.com/#/intention-notarize?Type=119&bizid=I20220114181457000001">https://companyreg.console.aliyun.com/#/intention-notarize?Type=119&amp;bizid=I20220114181457000001</a></para>
        /// </summary>
        [NameInMap("ConfirmUrl")]
        [Validation(Required=false)]
        public string ConfirmUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NoPermission</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0A3CFCF5-E0C0-5C0B-A2ED-03827F16D85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>S20211109140729000001</para>
        /// </summary>
        [NameInMap("SolutionBizId")]
        [Validation(Required=false)]
        public string SolutionBizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
