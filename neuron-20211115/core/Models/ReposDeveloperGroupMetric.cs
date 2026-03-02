// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ReposDeveloperGroupMetric : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>342</para>
        /// </summary>
        [NameInMap("addLines")]
        [Validation(Required=false)]
        public long? AddLines { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>242</para>
        /// </summary>
        [NameInMap("commentLines")]
        [Validation(Required=false)]
        public long? CommentLines { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("commitCnt")]
        [Validation(Required=false)]
        public long? CommitCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("delLines")]
        [Validation(Required=false)]
        public long? DelLines { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>129</para>
        /// </summary>
        [NameInMap("modLines")]
        [Validation(Required=false)]
        public long? ModLines { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>旭坤</para>
        /// </summary>
        [NameInMap("showName")]
        [Validation(Required=false)]
        public string ShowName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>64634</para>
        /// </summary>
        [NameInMap("workNo")]
        [Validation(Required=false)]
        public string WorkNo { get; set; }

    }

}
