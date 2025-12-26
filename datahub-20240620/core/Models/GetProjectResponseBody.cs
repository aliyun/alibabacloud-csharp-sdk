// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Datahub20240620.Models
{
    public class GetProjectResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1724041098000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1559031978056215</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A20A7093-8FE0-058C-BE0C-3C8057D5F1A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12252454</para>
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public long? Storage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1724041098000</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[11.22.33.44]</para>
        /// </summary>
        [NameInMap("VpcWhitelist")]
        [Validation(Required=false)]
        public string VpcWhitelist { get; set; }

    }

}
