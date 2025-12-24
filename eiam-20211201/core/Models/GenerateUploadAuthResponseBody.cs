// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GenerateUploadAuthResponseBody : TeaModel {
        /// <summary>
        /// <para>认证的AccessId</para>
        /// 
        /// <b>Example:</b>
        /// <para>STS.NYgAmE3cyPoMDxtWgtwG3xxxx</para>
        /// </summary>
        [NameInMap("AccessId")]
        [Validation(Required=false)]
        public string AccessId { get; set; }

        /// <summary>
        /// <para>预下载地址</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://temp.oss.aliyuncs.com/idaas_ly77wa2oexrciw5v672vizxxxx/file_import/68866d21-0ab7-450d-b9e6-5b1eafe06xxxx">https://temp.oss.aliyuncs.com/idaas_ly77wa2oexrciw5v672vizxxxx/file_import/68866d21-0ab7-450d-b9e6-5b1eafe06xxxx</a></para>
        /// </summary>
        [NameInMap("DownLoadUrl")]
        [Validation(Required=false)]
        public string DownLoadUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJhbGciOiJkaXIiLCJlbmMiOiJBMjU2R0NNIiwia2lkIjoia2V5X3Z1ZWhjbmh2NWppcGhmZGJwcWpqd3dsemFhIn0..YetpxsPdqdLvAy6G.0Zy5meoTzvCuNfA_0w7E9ItY2uGu1v1BxR9i98KeHXv_P-sm9w1q0XPf5Fw.55V_jFq2t2ZHdjg5c7uxxxx</para>
        /// </summary>
        [NameInMap("EncryptedKey")]
        [Validation(Required=false)]
        public string EncryptedKey { get; set; }

        /// <summary>
        /// <para>过期时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>1766470716</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        /// <summary>
        /// <para>bucket地址host</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://temp.oss.aliyuncs.com">https://temp.oss.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>认证对应的key</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas-csv://idaas_ly77wa2oexrciw5v672vizxxxx
        /// /file_import/68866d21-0ab7-450d-b9e6-5b1eafxxxx&quot;</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fBLqWEvq3SbCj1cX/rtZoSPDVduOWdloOO2VN2+5Sxxxx</para>
        /// </summary>
        [NameInMap("PlaintextKey")]
        [Validation(Required=false)]
        public string PlaintextKey { get; set; }

        /// <summary>
        /// <para>认证的policy</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJleHBpcmF0aW9uIjoiMjAyNS0xMi0yM1QwNjoxODozNi4zNTZaIiwiY29uZGl0aW9ucyI6W1siY29udGVudC1sZW5ndGgtcmFuZ2UiLDAsMTA0ODU3NjBdLHsiYnVja2V0IjoidGVtcC1pZGFhcy1laWFtLWNuLWhhbmd6aG91In0seyJrZXkiOiJpZGFhc19seTc3d2Eyb2V4cmNpdzV2Njcydml6eG12ZS9maWxlX2ltcG9ydC82ODg2NmQyMS0wYWI3LTQ1MGQtYjllNi01YjFlYWZlMDYzZTEifSx7Ingtb3NzLWZvcmJpZC1vdmVyd3JpdGUiOiJ0cnVlIn0seyJ4LW9zcy1vYmplY3QtYWNsIjoicHJpdmF0ZSJxxxx</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CAISzgJ1q6Ft5B2yfSjIr5rSCtfx3rxY562mRl7Fs2che8gfpbLg1zz2IHhMfXVpA+Afv/sxlG5Q7/wdlrp6SJtIXleCZtF94oxN9h2gb4fb4wgFPgjY08/LI3OaLjKm9u2wCryLYbGwU/OpbE++5U0X6LDmdDKkckW4OJmS8/BOZcgWWQ/KBlgvRq0hRG1YpdQdKGHaONu0LxfumRCwNkdzvRdmgm4NgsbWgO/ks0aO0wehm7BO+N6gfcD9NvMBZskvD42Hu8VtbbfE3SJq7BxHybx7lqQs+02c5onEXwALs0zXbLSErIU2dlBjH68hAOtFquPgnPtzt6nJkID62421pmiSr561rumAtyikcIvBXr5RHT3LoP1LA5UhHC1UotFVgGOaCXLbtuArXptaY/JiNL/0hFEpVt7knInNpUbntINy5f5fqzNMlShqKOXTK93xGoABgfahfEFC23BhLp3NnBxnaG/psewhUfRg/wYS9oE268EST0qPq0ZvzmZjsmtbtnFL8takNDOIdutBZeb9nngkEi7tYyVcwoYBnbJ3sopnFEVozB2VO5XuRHLBkOfB+2z1zD91KtoDajJxpT295Qm0ndFALS1tCGI452yRIrCHynggxxxxx</para>
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>认证的签名</para>
        /// 
        /// <b>Example:</b>
        /// <para>t3JyykEKg3kHQuUrhaXYxtboUxxxxx</para>
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

    }

}
