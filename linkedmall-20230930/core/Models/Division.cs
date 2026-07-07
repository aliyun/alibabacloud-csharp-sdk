// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class Division : TeaModel {
        /// <summary>
        /// <para>Address encoding</para>
        /// 
        /// <b>Example:</b>
        /// <para>310000</para>
        /// </summary>
        [NameInMap("divisionCode")]
        [Validation(Required=false)]
        public long? DivisionCode { get; set; }

        /// <summary>
        /// <para>Address Level</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("divisionLevel")]
        [Validation(Required=false)]
        public long? DivisionLevel { get; set; }

        /// <summary>
        /// <para>Address Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>上海</para>
        /// </summary>
        [NameInMap("divisionName")]
        [Validation(Required=false)]
        public string DivisionName { get; set; }

        /// <summary>
        /// <para>Parent ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// <para>Address pinyin</para>
        /// 
        /// <b>Example:</b>
        /// <para>shang hai</para>
        /// </summary>
        [NameInMap("pinyin")]
        [Validation(Required=false)]
        public string Pinyin { get; set; }

    }

}
