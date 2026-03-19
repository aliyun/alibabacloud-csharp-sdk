// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DLColumn : TeaModel {
        /// <summary>
        /// <para>The comment of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>from deserializer</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The name of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>col</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The data type of the column, including array, bigint, binary, boolean, char, date, decimal, double, float, int, interval, map, set, smallint, string, struct, timestamp, tinyint, union, varchar.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
