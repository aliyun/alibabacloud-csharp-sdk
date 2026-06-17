// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeCharacterSetNameResponseBody : TeaModel {
        [NameInMap("CharacterSetNameItems")]
        [Validation(Required=false)]
        public DescribeCharacterSetNameResponseBodyCharacterSetNameItems CharacterSetNameItems { get; set; }
        public class DescribeCharacterSetNameResponseBodyCharacterSetNameItems : TeaModel {
            [NameInMap("CharacterSetName")]
            [Validation(Required=false)]
            public List<string> CharacterSetName { get; set; }

        }

        /// <summary>
        /// <para>The cluster engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POLARDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34458CD3-33E0-4624-BFEF-840C15******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
