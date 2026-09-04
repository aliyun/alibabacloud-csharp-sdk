// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLProgressEval : TeaModel {
        /// <summary>
        /// <para>Indicates whether Total is greater than 0 and Finished is not less than Total.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Done")]
        [Validation(Required=false)]
        public bool? Done { get; set; }

        /// <summary>
        /// <para>The number of finished samples.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("Finished")]
        [Validation(Required=false)]
        public int? Finished { get; set; }

        /// <summary>
        /// <para>The progress percentage, which is the ratio of Progress to Total.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Pct")]
        [Validation(Required=false)]
        public double? Pct { get; set; }

        /// <summary>
        /// <para>The progress count, which is the greater value of Ready and Finished.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// <para>The number of ready samples.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("Ready")]
        [Validation(Required=false)]
        public int? Ready { get; set; }

        /// <summary>
        /// <para>The target number of samples.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
